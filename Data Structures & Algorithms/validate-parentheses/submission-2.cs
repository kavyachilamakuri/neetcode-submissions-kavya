public class Solution {
    public bool IsValid(string s) {
        Stack<char> st= new Stack<char>();
        if(s.Length%2!=0) return false;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='('|| s[i]=='{'||s[i]=='['){
                st.Push(s[i]);
            }
            else if(s[i]==')'|| s[i]=='}'||s[i]==']'){
                if(st.Count>0){
                    var curr=st.Pop();
                    if(s[i]==')'&&curr!='('){
                        return false;
                    }
                    else if(s[i]==']'&& curr!='['){
                        return false;
                    }
                    else if(s[i]=='}'&& curr!='{'){
                        return false;
                    }
                }
                else return false;
            }
        }
        if(st.Count==0) return true;
        else return false;
    }
}
