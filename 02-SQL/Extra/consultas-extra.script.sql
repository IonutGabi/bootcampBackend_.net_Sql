
-- Listar las pistas ordenadas por el n�mero de veces que aparecen en playlists de forma descendente

SELECT T.Name AS TrackName, COUNT(T.TrackId) AS NumeroDeApariciones
FROM dbo.Track T
INNER JOIN dbo.PlaylistTrack PT ON PT.TrackId = T.TrackId
INNER JOIN dbo.Playlist P ON P.PlaylistId = PT.PlaylistId
GROUP BY T.Name, T.TrackId
ORDER BY T.TrackId DESC

-- Listar las pistas m�s compradas (la tabla InvoiceLine tiene los registros de compras)

SELECT T.Name AS TrackName, COUNT(I.TrackId) AS M�sVecesComprada
FROM dbo.Track T
INNER JOIN dbo.InvoiceLine I ON I.TrackId = T.TrackId 
GROUP BY T.Name 
ORDER BY M�sVecesComprada DESC

-- Listar los artistas m�s comprados

SELECT  Ar.Name AS ArtistName, COUNT(I.TrackId) AS M�sComprado
FROM dbo.Track T
INNER JOIN dbo.Album A ON A.AlbumId = T.AlbumId
INNER JOIN dbo.InvoiceLine I ON I.TrackId = T.TrackId
INNER JOIN dbo.Artist Ar ON Ar.ArtistId = A.ArtistId
GROUP BY Ar.Name
ORDER BY M�sComprado DESC

-- Listar las pistas que a�n no han sido compradas por nadie

SELECT T.Name AS TrackName
FROM dbo.Track T
LEFT JOIN dbo.InvoiceLine I ON I.TrackId = T.TrackId
GROUP BY T.Name
HAVING COUNT(I.TrackId) = 0

-- Listar los artistas que a�n no han vendido ninguna pista

SELECT Ar.Name AS ArtistName
FROM dbo.Track T
INNER JOIN dbo.Album A ON A.AlbumId = T.AlbumId
LEFT JOIN dbo.InvoiceLine I ON I.TrackId = T.TrackId
LEFT JOIN dbo.Artist Ar ON Ar.ArtistId = A.ArtistId
GROUP BY Ar.Name
HAVING COUNT(I.TrackId) = 0