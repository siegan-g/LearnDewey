
namespace PROG7312_POE;
    class ReorderBooks
    {
        private List<String>CallNumberList = new List<String>();
        //returns a list of random call numbers
        //call number contains random numbers 000-999 and random decimals .000 - .999 with random letters AAA-ZZZ
        public ReorderBooks(List<String> CallNumberList)
        {
           this.CallNumberList= CallNumberList;     
        } 
        public  String RandomizeCallNumber()
        {
            Random rnd = new Random();
            int wholeNumb = rnd.Next(0,999);
            int deci = rnd.Next(0,999);
            int letterPos=0;
            String author = "";
            char[] alphabet = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','N','Q','R','S','T','U','V','X','Y','Z'};

            for (int i = 0; i < 3; i++)
            {
                letterPos = rnd.Next(0,25);
                author += alphabet[letterPos];
            }
            return wholeNumb.ToString("000")+'.'+deci.ToString("000")+author;
        }

    public List<String> SortListAscending()
    {
         CallNumberList.Sort();
         return CallNumberList;
    }
    
    public bool CompareCallNumberList(List<String> userCallNumberList )
    {
        bool isEqual = false;
        for (int i = 0; i < CallNumberList.Count(); i++)
        {
              if(!CallNumberList.ElementAt(i).Equals(userCallNumberList.ElementAt(i))){
                  break;
              }
              else {
                  isEqual = true;
              }
        }
        return isEqual;
    }

}
