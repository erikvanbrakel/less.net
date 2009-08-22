using System;
using System.Collections.Generic;
using System.Linq;

public static class Extensions
{

	public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source, Func<T, T, bool> comparer)
	{
		return source.Distinct(new DelegateComparer<T>(comparer));
	}

	public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source, Func<T, T, bool> comparer, Func<T, int> hashMethod)
	{
		return source.Distinct(new DelegateComparer<T>(comparer, hashMethod));
	}

}

public class DelegateComparer<T> : IEqualityComparer<T>
{

	private readonly Func<T, T, bool> _equals;
	private readonly Func<T, int> _getHashCode;

	public DelegateComparer(Func<T, T, bool> equals)
	{
		_equals = equals;
	}

	public DelegateComparer(Func<T, T, bool> equals, Func<T, int> getHashCode)
	{
		_equals = equals;
		_getHashCode = getHashCode;
	}

	public bool Equals(T a, T b)
	{
		return _equals(a, b);
	}

	public int GetHashCode(T a)
	{
		return _getHashCode != null ? _getHashCode(a) : a.GetHashCode();
	}
}
