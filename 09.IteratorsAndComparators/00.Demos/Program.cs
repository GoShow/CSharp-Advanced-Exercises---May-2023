using System;
using System.Collections;
using System.Collections.Generic;

ConcertHall concertHall = new(new List<int> { 1, 2, 3 });

foreach (var seat in concertHall)
{
    Console.WriteLine(seat);
}

//ConcertHallEnumerator concertHallEnumerator = new(new List<int> { 1, 2, 3 });

//while (concertHallEnumerator.MoveNext())
//{
//    Console.WriteLine(concertHallEnumerator.Current);
//}


public class ConcertHall : IEnumerable<int>
{
    private List<int> seats;

    public ConcertHall(List<int> seats)
    {
        this.seats = seats;
    }


    public IEnumerator<int> GetEnumerator()
    {
        return new ConcertHallEnumerator(seats);

        //foreach (var seat in seats)
        //{
        //    yield return seat;
        //}


        //reversed
        //for (int i = seats.Count - 1; i >= 0; i--)
        //{
        //    yield return seats[i];
        //}
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class ConcertHallEnumerator : IEnumerator<int>
{
    private int index = -1;
    private List<int> seats;

    public ConcertHallEnumerator(List<int> seats)
    {
        this.seats = seats;
    }

    public int Current => seats[index];

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        index++;

        return index < seats.Count;
    }

    public void Reset()
    {
        index = -1;
    }

    public void Dispose()
    {
    }
}