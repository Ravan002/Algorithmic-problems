import java.util.HashSet;

public class Solutions {


    // Problem 3110. Score of a String
    public int scoreOfString(String s) {
        int result=0;
        for(int i=0;i<s.length()-1;i++){
            result += Math.abs(s.charAt(i)-s.charAt(i+1));
        }
        return result;
    }

    public void reverseString(char[] s) {
        for(int i=1; i<=s.length/2;i++){
            char temp=s[i-1];
            s[i-1]=s[s.length-i];
            s[s.length-i]=temp;
        }
    }

    public int appendCharacters(String s, String t) {
        int j=0;
        char[] s1= s.toCharArray();
        char[] t1= s.toCharArray();

        for(int i=0; i< s.length();i++){
            if(j==t1.length) break;
            if(s1[i]==t1[j]){
                j++;
            }
        }
        return t1.length-j;
    }


    public int longestPalindrome(String s) {
        HashSet<Character> letter= new HashSet<>();
        int count=0;
        if(s.length()==1)return 1;
        for (char c : s.toCharArray()) {

            if (letter.contains(c)) {
                letter.remove(c);
                count += 2;
            } else {
                letter.add(c);
            }
        }
        return letter.isEmpty() ? count : count + 1;
    }

    public int removeElement(int[] nums, int val) {
        int count=0;

        for(int i=0;i<nums.length;i++){
            if(nums[i]!=val){
                nums[count++]=nums[i];
            }
        }

        return count;
    }

    public String mergeAlternately(String word1, String word2) {
        int i=0,j=0;
        StringBuilder merged=new StringBuilder();

        while(i<word1.length() && j<word2.length()){
            merged.append(word1.charAt(i++));
            merged.append(word2.charAt(j++));
        }
        while (i<word1.length()){
            merged.append(word1.charAt(i++));
        }
        while (j<word2.length()){
            merged.append(word2.charAt(j++));
        }

        return merged.toString();
    }
}
