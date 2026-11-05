namespace GameStore.Api.Dtos;

// A DTO is a contract between client and server since it represents
// a shared agreement of how data will be transferred and used.


public record GameDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);
