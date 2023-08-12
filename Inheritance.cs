namespace InheritanceDemo
{
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the BDay wishes", true, "Mahta Ebadi");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost = new ImagePost("Check out my new shoes", "Mahta Ebadi", "www.nike.com", true);
            Console.WriteLine(imagePost.ToString());
        }
    }
}