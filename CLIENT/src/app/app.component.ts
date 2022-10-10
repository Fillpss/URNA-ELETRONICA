import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { throwIfEmpty } from 'rxjs';

@Component({
  selector: 'app-root', // Onde vai ser renderizado
  templateUrl: './app.component.html', // HTML que vai ser renderizado
  styleUrls: ['./app.component.css'] // CSS que vai ser renderizado
})

export class AppComponent implements OnInit {
  // Variáveis que serão consumidas pelo templateURL
  title = 'Candidatos'; 
  candidatos: any; 
  votos: any;

  constructor(private http : HttpClient) {}

  ngOnInit(): void {
    this.getCandidatos();
    this.getVotos();
  }

  getCandidatos() {
    this.http.get("https://localhost:7237/api/Candidato").subscribe(response => {
      this.candidatos = response;
    }, error => {
      console.log(error);
    });
  }

  getVotos() {
    this.http.get("https://localhost:7237/api/Voto").subscribe(response => {
      this.votos = response;
    }, error => {
      console.log(error);
    });
  }
}