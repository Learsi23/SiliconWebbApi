USE [Silicon_Database];
GO

-- Verifica si la tabla existe
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Courses')
BEGIN
    -- Inserta los datos adaptados a la estructura real de tu tabla
    INSERT INTO Courses (
        [Id], 
        [Title], 
        [Author], 
        [ImageName], 
        [Price], 
        [Discount], 
        [Hours], 
        [IsBestSeller], 
        [IsDigital], 
        [LikesNumbers], 
        [LikesProcent], 
        [DateCreated], 
        [LastUpdated], 
        [CategoryId]
    )
    VALUES
        (NEWID(), 'Fullstack Web Developer Course from Scratch', 'Robert Fox', 'image (1).svg', 12.50, 0.00, 160, 1, 0, '3.1', '92', '2024-04-05', GETDATE(), 2),
        (NEWID(), 'The Complete HTML, CSS, JavaScript Web Course', 'Jenny Wilson & Marvin McKinney', 'image (2).svg', 15.99, 0.00, 160, 0, 0, '3.1', '92', '2024-04-05', GETDATE(), 1),
        (NEWID(), 'The Complete Front-End Web Development Course', 'Albert Flores', 'image (3).svg', 9.99, 44.99, 160, 0, 0, '4.2', '94', '2024-04-05', GETDATE(), 1),
        (NEWID(), 'iOS & Swift - The Complete iOS App Development Course', 'Marvin McKinney', 'image (4).svg', 15.99, 0.00, 160, 0, 0, '3.1', '92', '2024-04-05', GETDATE(), 3),
        (NEWID(), 'Data Science & Machine Learning with Python', 'Esther Howard', 'image (5).svg', 11.20, 0.00, 100, 1, 0, '3.1', '92', '2024-04-05', GETDATE(), 4),
        (NEWID(), 'Creative CSS Drawing Course: Make Art With CSS', 'Robert Fox', 'image (6).svg', 10.50, 0.00, 220, 0, 0, '4.2', '94', '2024-04-05', GETDATE(), 1),
        (NEWID(), 'Blender Character Creator v2.0 for Video Games Design', 'Ralph Edwards', 'image (7).svg', 18.99, 0.00, 160, 0, 0, '3.1', '92', '2024-04-06', GETDATE(), 5),
        (NEWID(), 'The Ultimate Guide to 2D Mobile Game Development with Unity', 'Albert Flores', 'image (8).svg', 12.99, 44.99, 100, 0, 0, '2.7', '98', '2024-04-06', GETDATE(), 2),
        (NEWID(), 'Learn JMETER from Scratch on Live Apps-Performance Testing', 'Jenny Wilson', 'image (9).svg', 14.50, 0.00, 160, 0, 0, '3.1', '92', '2024-04-06', GETDATE(), 5);

    PRINT '¡Datos insertados correctamente!';
END
ELSE
BEGIN
    PRINT 'Error: La tabla "Courses" no existe.';
END
GO

-- Verifica los datos insertados
SELECT * FROM Courses;
GO