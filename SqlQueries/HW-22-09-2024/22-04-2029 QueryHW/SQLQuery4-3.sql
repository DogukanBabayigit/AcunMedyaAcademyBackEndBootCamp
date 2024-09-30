SELECT 
    s.StudentName,
    b.BookName,
    bu.BorrowTime
FROM 
    BorrowTable bu
INNER JOIN Students s ON bu.StudentID = s.StudentID
INNER JOIN Books b ON bu.BookID = b.BookID;