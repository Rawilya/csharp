using System;
using System.Collections;
using System.Xml.Serialization;


namespace project;
[Serializable]
 
public class Users{

   public string? name;
   public string? login;
   public int age;
   
 
   public Users(){}
   public  Users(string name, string login, int age,List<string> hobbies)
   {
      this.name= name;
      this.login= login;
      this.age = age;
      this.hobbies = hobbies;
      
      
   }
   List<string> hobbies = new List<string>(){"sport", "fishing"};

   public string GetInfo()
{
        string info = $"Пользователь: {name} с логином {login}. Его возраст: {age}. Хобби:\n";
        foreach (string el in hobbies)
            info += $"{el}\n";
        return info;
}



   
  
}



   
   
   
 


   

  
