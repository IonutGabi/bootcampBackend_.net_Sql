-- Listar las pistas (tabla Track) con precio mayor o igual a 1€

SELECT T.TrackId, T.Name, T.UnitPrice
FROM dbo.Track T
WHERE T.UnitPrice >= 1

-- Listar las pistas de más de 4 minutos de duración

SELECT T.TrackId, T.Name, T.Milliseconds
FROM dbo.Track T
WHERE T.Milliseconds > 240000

-- Listar las pistas que tengan entre 2 y 3 minutos de duración

SELECT T.TrackId, T.Name, T.Milliseconds
FROM dbo.Track T
WHERE T.Milliseconds BETWEEN 120000 AND 180000

-- Listar las pistas que uno de sus compositores (columna Composer) sea Mercury

SELECT T.TrackId, T.Name, T.Composer
FROM dbo.Track T
WHERE T.Composer = 'Mercury'

-- Calcular la media de duración de las pistas (Track) de la plataforma

SELECT AVG(T.Milliseconds) AS MediaDeDuracionDeLasPistas
FROM dbo.Track T

-- Listar los clientes (tabla Customer) de USA, Canada y Brazil

SELECT C.CustomerId, C.FirstName, C.LastName, C.Country
FROM dbo.Customer C
WHERE C.Country IN ('USA', 'Canada', 'Brazil')

-- Listar todas las pistas del artista 'Queen' (Artist.Name = 'Queen')

SELECT T.TrackId, T.Name AS TrackName, Art.Name AS ArtistName
FROM dbo.Artist Art
INNER JOIN dbo.Album A ON A.ArtistId = Art.ArtistId
INNER JOIN dbo.Track T ON T.AlbumId = A.AlbumId
WHERE Art.Name = 'Queen'

-- Listar las pistas del artista 'Queen' en las que haya participado como compositor David Bowie

SELECT T.TrackId, T.Name AS TrackName, Art.Name AS ArtistName, T.Composer
FROM dbo.Artist Art
INNER JOIN dbo.Album A ON A.ArtistId = Art.ArtistId
INNER JOIN dbo.Track T ON T.AlbumId = A.AlbumId
WHERE Art.Name = 'Queen' AND T.Composer = 'Roger Taylor'

-- Listar las pistas de la playlist 'Heavy Metal Classic'

SELECT T.TrackId, T.Name AS TrackName, PL.Name AS PlaylistName
FROM dbo.Track T
INNER JOIN dbo.PlaylistTrack PT ON PT.TrackId = T.TrackId
INNER JOIN dbo.Playlist PL ON PL.PlaylistId = PT.PlaylistId
WHERE PL.Name = 'Heavy Metal Classic'

-- Listar las playlist junto con el número de pistas que contienen

SELECT PL.Name AS PlaylistName, COUNT(T.TrackId) AS NumeroDePistas
FROM dbo.Track T
INNER JOIN dbo.PlaylistTrack PT ON PT.TrackId = T.TrackId
INNER JOIN dbo.Playlist PL ON PL.PlaylistId = PT.PlaylistId
GROUP BY PL.Name

-- Listar las playlist (sin repetir ninguna) que tienen alguna canción de AC/DC

SELECT DISTINCT PL.Name AS PlaylistName, T.Composer
FROM dbo.Track T
INNER JOIN dbo.PlaylistTrack PT ON PT.TrackId = T.TrackId
INNER JOIN dbo.Playlist PL ON PL.PlaylistId = PT.PlaylistId
WHERE T.Composer = 'AC/DC'

-- Listar las playlist que tienen alguna canción del artista Queen, junto con la cantidad que tienen

SELECT P.Name AS PlaylistName, COUNT(P.PlaylistId) AS NumeroDeCanciones
FROM dbo.Playlist P
INNER JOIN dbo.PlaylistTrack PT ON PT.PlaylistId = P.PlaylistId
INNER JOIN dbo.Track T ON T.TrackId = PT.TrackId
INNER JOIN dbo.Album A ON A.AlbumId = T.AlbumId
INNER JOIN dbo.Artist Art ON Art.ArtistId = A.ArtistId
WHERE Art.Name = 'Queen'
GROUP BY P.PlaylistId, P.Name

-- Listar las pistas que no están en ninguna playlist

-- Listar los artistas que no tienen album

SELECT Ar.Name AS ArtistName, COUNT(A.AlbumId) AS NumeroDeAlbumes
FROM dbo.Artist Ar
LEFT JOIN dbo.Album A ON A.ArtistId = Ar.ArtistId
GROUP BY Ar.Name
HAVING COUNT(A.AlbumId) = 0

-- Listar los artistas con el número de albums que tienen

SELECT Ar.Name AS ArtistName, COUNT(A.AlbumId) AS NumeroDeAlbumes
FROM dbo.Artist Ar
LEFT JOIN dbo.Album A ON A.ArtistId = Ar.ArtistId
GROUP BY Ar.Name