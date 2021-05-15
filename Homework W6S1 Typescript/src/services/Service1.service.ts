import movies from '../data/movies.json';

class Reservation
{
    id:number = 0;
    movie_id:number = 0;
    static id_index:number = 10;
    Seats:Array<number> = [];
    Reservation()
    {
        this.id = Reservation.id_index++;
    }
}

export class Service1 {
    /**
     * getMovies
     * TODO: define and specify a return type. Normally, typescript will infere it
     * but for the purposes of this exercise, let's specify it 
     */

    readonly nr_seats : number = 6;
    reservations:Array<Reservation> = []
    reservation_index:number = -1;

    public getMovies():string {
        let output:string = "";
        movies.forEach(movie => {output+= "Title: " + movie.title + "<br>" + "Time: " + movie.time + "<br><br>";
        });
        return output;
    }

    public getMovieSeats(id:number) {
        let output:string = "Available seats:";
        let x:any = 0;
        movies.forEach(movie => { if(movie.id === id) {x = movie}
        });
        for(let i:number = 1; i <= this.nr_seats; i++)
        {
            if(!x.occupied_seats.includes(i))
            {
                output += i + " ";
            }
        }
        return output;
    }

    public SetReservation(id:number, seats:Array<string>) {//TypeError: Cannot read property 'push' of undefined
        let x:any = 0;
        movies.forEach(movie => { if(movie.id === id) {x = movie}
        });

        this.reservation_index++;
        this.reservations[this.reservation_index]=new Reservation();

        seats.forEach(seat => {
            this.reservations[this.reservation_index].Seats.push(Number(seat));
            x.occupied_seats.push(Number(seat));
        });
    
        return "Reservation number " + this.reservation_index + " made!";
    }

    
    public CancelReservation(id:number) {
        let currectReservation:Reservation = new Reservation();
        this.reservations.forEach(reservation => { 
            if(reservation.id === id) 
            {
                currectReservation = reservation;
            }
        });
        
        currectReservation.Seats.forEach(seat => {
            delete movies[currectReservation.movie_id].occupied_seats[seat - 1];
        });

        delete this.reservations[this.reservations.indexOf(currectReservation)]
        return "Reservation number " + id + " cancelled!";
    }
}