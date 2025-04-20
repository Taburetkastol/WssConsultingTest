namespace Persistence.Exceptions;

/// <summary>
/// Кастомное исключение, обозначающее конфликт при одновременных изменениях.
/// </summary>
public class ConcurrencyException(string message, Exception? inner = null) : Exception(message, inner);