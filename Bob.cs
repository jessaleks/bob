using System;
using System.Linq;

public static class Bob
{
    /**
        'Sure.' if you ask him a question, such as "How are you?".
        'Whoa, chill out!' if you YELL AT HIM (in all capitals).
        'Calm down, I know what I'm doing!' if you yell a question at him.
        'Fine. Be that way!' if you address him without actually saying anything.
        'Whatever.' to anything else.
    */
    public static string Response(string statement)
    {

        return statement switch
        {
            var s when s.EndsWith('?') => "Sure.",
            var s when s.ToUpper() == s => "Whoa, chill out!",
            // TODO it's getting late. finish later.
            _ => "Whatever"
        }
    }
}