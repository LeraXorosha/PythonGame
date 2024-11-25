private static Demo2Entities _context;


public static Demo2Entities GetContext()
{
    if (_context == null)
        _context = new Demo2Entities();
    return _context;
}