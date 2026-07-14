public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb=new StringBuilder();
        foreach(var str in strs){
            sb.Append(str.Length);
            sb.Append("#");
            sb.Append(str);
        }
        return sb.ToString();
        
    }

   public List<string> Decode(string s) {
    List<string> list = new List<string>();
    int i = 0;

    while (i < s.Length) {
        // find the '#' that ends the length prefix
        int j = i;
        while (s[j] != '#') {
            j++;
        }

        int length = int.Parse(s.Substring(i, j - i)); // digits between i and j
        string str = s.Substring(j + 1, length);        // the actual content
        list.Add(str);

        i = j + 1 + length; // move past this entry
    }

    return list;
}
}
