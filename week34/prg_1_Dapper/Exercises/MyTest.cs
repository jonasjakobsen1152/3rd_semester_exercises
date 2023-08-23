using Dapper;

namespace gettingstarted.week34.prg_1_Dapper.Exercises;

public class MyTest
{

    public bool createAuthorBookRelationship(int bookId, int authorId)
    {
        var sql = $@"
        INSERT INTO library.author_wrote_book_items (book_Id, author_Id) VALUES (@book_Id, @author_Id)
         ";
        
        using (var conn = Helper.DataSource.OpenConnection())
        {
            return conn.Execute(sql, new { bookId, authorId }) == 1;
        }
    }
    
    
}