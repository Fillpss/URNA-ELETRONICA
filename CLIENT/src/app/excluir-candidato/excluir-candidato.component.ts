import { HttpBackend } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-excluir-candidato',
  templateUrl: './excluir-candidato.component.html',
  styleUrls: ['./excluir-candidato.component.css']
})
export class ExcluirCandidatoComponent implements OnInit {

  candidatos: any;
  
  ExcluirCandidato(id: Number) {
    this.http.delete(`https://localhost:7237/api/Candidato/${id}`).subscribe(response => {
      console.log("Deletado com Sucesso!");
      this.BuscarCandidatos();
    }, error => {
      console.log(error);
    });
  }

  BuscarCandidatos() {
    this.http.get("https://localhost:7237/api/Candidato").subscribe(response => {
      this.candidatos = response;
    }, error => {
      console.log(error);
    });
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.BuscarCandidatos();
  }

}
