<template>
  <v-form ref="form" v-model="valid" lazy-validation>
    <v-text-field v-model="dadosCliente.nome" :counter="20" :rules="nameRules" label="Nome" required></v-text-field>

    <v-text-field v-model="dadosCliente.sobrenome" :counter="30" :rules="sobrenomeRules" label="Sobrenome" required>
    </v-text-field>

    <v-text-field v-model="dadosClienteEmail" :rules="emailRules" label="E-mail" required></v-text-field>

    <v-select v-model="select" :items="items" :rules="[(v) => !!v || 'Zona da cidade requerida']" label="Zona da Cidade" required>
    </v-select>

    <v-checkbox v-model="checkbox" :rules="[(v) => !!v || 'Você deve concordar para continuar']" label="Você concorda em compartilhar os seus dados?"
      required></v-checkbox>

    <v-btn :disabled="!valid" color="success" class="mr-4" @click="submit">
      Validação
    </v-btn>

    <v-btn color="error" class="mr-4" @click="reset">
      Cancelar
    </v-btn>

    <v-btn color="warning" @click="resetValidation">
      Resetar Formulário
    </v-btn>
  </v-form>



</template>
<script>


export default {
  data: () => ({
    valid: true,
    dadosCliente: {
      nome: "",
      sobrenome: "",
      email: "",
    },
    nome: "",
    nomeRules: [
      (v) => !!v || "Name is required",
      (v) => (v && v.length <= 10) || "O nome deve ter ao menos 10 caracteres",
    ],
    valid: true,
    sobrenome: "",
    sobrenomeRules: [
      (v) => !!v || "Name is required",
      (v) => (v && v.length >= 5) || "O sobrenome deve ter ao menos 5 caracteres",
    ],
    email: "",
    emailRules: [
      (v) => !!v || "E-mail is required",
      (v) => /.+@.+\..+/.test(v) || "E-mail must be valid",
    ],
    select: null,
    items: ["Zona Norte", "Zona Sul", "Zona Oeste", "Zona Leste", "Centro"],
    checkbox: false,
  }),

  methods: {

    async submit() {

      debugger

      var response = await this.$axios()({
        method: 'post',
        url: '/user/12345',
        data: this.dadosCliente,
      });
      debugger
    }, catch: {}

  },
  reset() {
    this.$refs.form.reset();
  },
  resetValidation() {
    this.$refs.form.resetValidation();
  },
};
</script>
<style>

</style>