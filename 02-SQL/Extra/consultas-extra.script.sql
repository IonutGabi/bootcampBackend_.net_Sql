
-- Listar las pistas ordenadas por el número de veces que aparecen en playlists de forma descendente

SELECT T.Name AS TrackName, COUNT(T.TrackId) AS NumeroDeApariciones
FROM dbo.Track T
INNER JOIN dbo.PlaylistTrack PT ON PT.TrackId = T.TrackId
INNER JOIN dbo.Playlist P ON P.PlaylistId = PT.PlaylistId
GROUP BY T.Name, T.TrackId
ORDER BY T.TrackId DESC

-- Listar las pistas más compradas (la tabla InvoiceLine tiene los registros de compras)

SELECT T.Name AS TrackName, COUNT(I.TrackId) AS MásVecesComprada
FROM dbo.Track T
INNER JOIN dbo.InvoiceLine I ON I.TrackId = T.TrackId 
GROUP BY T.Name 
ORDER BY MásVecesComprada DESC

-- Listar los artistas más comprados

SELECT  Ar.Name AS ArtistName, COUNT(I.TrackId) AS MásComprado
FROM dbo.Track T
INNER JOIN dbo.Album A ON A.AlbumId = T.AlbumId
INNER JOIN dbo.InvoiceLine I ON I.TrackId = T.TrackId
INNER JOIN dbo.Artist Ar ON Ar.ArtistId = A.ArtistId
GROUP BY Ar.Name
ORDER BY MásComprado DESC

-- Listar las pistas que aún no han sido compradas por nadie

SELECT T.Name AS TrackName
FROM dbo.Track T
LEFT JOIN dbo.InvoiceLine I ON I.TrackId = T.TrackId
GROUP BY T.Name
HAVING COUNT(I.TrackId) = 0

-- Listar los artistas que aún no han vendido ninguna pista

SELECT Ar.Name AS ArtistName
FROM dbo.Track T
INNER JOIN dbo.Album A ON A.AlbumId = T.AlbumId
LEFT JOIN dbo.InvoiceLine I ON I.TrackId = T.TrackId
LEFT JOIN dbo.Artist Ar ON Ar.ArtistId = A.ArtistId
GROUP BY Ar.Name
HAVING COUNT(I.TrackId) = 0