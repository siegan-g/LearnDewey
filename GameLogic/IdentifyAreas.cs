namespace PROG7312_POE;


public class IdentifyAreas
{
//need a method to generate the areas 

// 4 questions by 7 definitions
// OR 
// 4 definitions by 7 questions 

    // private readonly Dictionary<string,Area> _areas = new Dictionary<string, Area>();   
    private readonly Dictionary<string,string> _areas = new Dictionary<string, string>();

    //populate the dictionary when the object is created
    // not really sure why i did this in the constructor
        // i guess to populate the dictionary on object instantiation instead of calling a method to set it

// As dictionaries are unordered Im not going to randomize the positions. As it iterates through each value it should not return as declared below.
    public IdentifyAreas()
    {
        _areas.Add("000","General Knowledge");
        _areas.Add("100","Philosophy and Psychology");
        _areas.Add("200","Religion");
        _areas.Add("300","Social Science");
        _areas.Add("400","Languages");
        _areas.Add("500","Science");
        _areas.Add("600","Technology");
        _areas.Add("700","Art & Recreation");
        _areas.Add("800","Literature");
        _areas.Add("900","History & Geography");
    }


    public Dictionary<string,string> GetAreas()
    {
        return _areas;
    }
    // need a method to match corresponding areas

    
   public int Matcher(List<String> questions, List<String> answers)
   {
        //Will return the number of matches 

        // Where column is either 1 or 3 in this case
        // column 1 being the question  and column 3 being the answer 
        // Say for example i have a question with the code 300 and the answer as Social Science
        // for each question (always 4 usually)
        // check a value and its corresponding answer to every element in the area dictionary (hence foreach)
        //Index out of bounds exceptions will arise if answers.Count()<questions.Count(); So I'm not using a dynamically sized structure 
        // Using an array with a predefined size
        //Some simple housekeeping to ensure you dont get an index out of bounds exception 
        int counter = 0;
        if(answers.Count>questions.Count)
        {
            return 0;
        }
        if(answers.Count<=questions.Count)
        {        
            for(int i = 0; i < questions.Count();i++)
            {
                foreach(var area in _areas)
                {                
                    Console.WriteLine(area.Key+" "+area.Value);
                    System.Console.WriteLine(questions[i]+" "+answers[i]);

                    //condition 1 - column 1 are definitions
                    if(area.Key.Equals(answers[i]) && area.Value.Equals(questions[i]))
                    {   
                        counter ++;
                    }
                    // condition 0 - column 1 are codes
                    else if (area.Key.Equals(questions[i]) && area.Value.Equals(answers[i]))
                    {
                        counter ++;
                    }
                }
            }
        }
        return counter;

    }
    // make dictionary key lookup otherwise it doesnt make much sense to a dictionary  
}
