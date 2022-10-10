import { Routes } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { CadastrarCandidatosComponent } from '../cadastrar-candidatos/cadastrar-candidatos.component';
import { ExcluirCandidatoComponent } from '../excluir-candidato/excluir-candidato.component';
import { VotarComponent } from '../votar/votar.component';
import { ApuracaoComponent } from '../apuracao/apuracao.component';

export const rotas: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'candidato', component: CadastrarCandidatosComponent },
  { path: 'excluir-candidato', component: ExcluirCandidatoComponent },
  { path: 'votar', component: VotarComponent },
  { path: 'apurar', component: ApuracaoComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' } // Padrão de abertura
];