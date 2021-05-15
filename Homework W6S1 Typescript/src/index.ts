import express, {Application, Request, Response, NextFunction} from 'express';
import { Service1 } from './services';

const port = Number(process.env.PORT || 3000);

const logRequest = (req: Request, res: Response, next: NextFunction) => {
  console.log(`${req.method} - ${req.originalUrl} ${JSON.stringify(req.params)}`);
  console.log(`${res.statusCode}`);
  next();
}

let service1:Service1 = new Service1();
const app: Application = express();
app.use(logRequest);

app.get( "/", (req, res) => {
    res.send( "Hello Typescript Assignment" );
});

app.get( "/movies", (req, res) => {
  //let service1 = new Service1();
  let response = service1.getMovies();
  res.send(response);
});

app.get( "/see", (req, res) => {//http://localhost:3000/see?id=101
    let id:number = Number(req.query.id);
    //let service1 = new Service1();
    let response = service1.getMovieSeats(id);
    res.send(response);
});

app.get( "/reserve", (req, res) => {
  //http://localhost:3000/reserve?id=101&seats=1,2
  //http://localhost:3000/reserve?id=101&seats=1&seats=2
  let seats:Array<string> = String(req.query.seats).split(",");
  let id:number = Number(req.query.id);
  //let service1 = new Service1();
  let response = service1.SetReservation(id, seats);
  res.send(response);
});

app.get( "/cancel", (req, res) => {//http://localhost:3000/cancel?id=101
    let id:number = Number(req.query.id);
    //let service1 = new Service1();
    let response = service1.CancelReservation(id);
    res.send(response);
});

app.listen(port, () => {
    console.log(`server started on port ${port}`);
});