namespace LinqPractices.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(){
            using (var context = new LinqDbContext()){
                if(context.Students.Any()){
                    return;
                }

                context.Students.AddRange(
                    new Student(){
                   
                        Name = "Mustafa",
                        Surname = "Albayrak",
                        ClassId = 1
                    },
                    new Student(){
                      
                        Name = "Tyler",
                        Surname = "Durden",
                        ClassId = 1
                    },
                    new Student(){
                       
                        Name = "Thomas",
                        Surname = "Shelby",
                        ClassId = 2
                    },
                    new Student(){
                      
                        Name = "Ryan",
                        Surname = "Gosling",
                        ClassId = 2
                    }
                );

                context.SaveChanges();
            }
        }
    }

}