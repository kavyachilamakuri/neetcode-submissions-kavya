public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st=new Stack<int>();
        for(int i=0;i<tokens.Length;i++){
            if(int.TryParse(tokens[i],out int num) ){
                st.Push(num);
            }
            else if(
                tokens[i]=="+"||
                tokens[i]=="-"
                ||tokens[i]=="*"||
                tokens[i]=="/")
            {
             int d2=st.Pop();
             int d1=st.Pop();
             int res= PerformOp(d1,d2,tokens[i][0]);
             st.Push(res);
            }
        }
        return st.Pop();
    }
    public int PerformOp(int d1,int d2, char op){
        if(op=='+') return d1+d2;
        if(op=='-') return d1-d2;
        if(op=='*') return d1*d2;
        if(op=='/') return d1/d2;
        return 0;
    }
}
