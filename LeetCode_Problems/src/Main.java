

public class Main {
    public static void main(String[] args) {

        Solutions s= new Solutions();
        int i=0,j=0;
        String word1="ab";
        String word2="pcd";
        StringBuilder merged=new StringBuilder();
        while(i<word1.length() && j<word2.length()){
            merged.append(word1.charAt(i++));
            merged.append(word2.charAt(j++));
        }
        System.out.println(merged);

    }
}