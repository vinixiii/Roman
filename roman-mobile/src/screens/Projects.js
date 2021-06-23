//Packages
import React from "react";
import {
  StyleSheet,
  Text,
  View,
  Image,
  TouchableOpacity,
  ScrollView,
} from "react-native";

//Components
// import { Header } from "../components/Header";

export function Projects() {
  return (
    <View style={styles.container}>
      {/* <Header /> */}

      <View style={styles.main}>
        <Text style={styles.title}>Projetos</Text>

        <View>
          <View style={styles.projects__card}>
            <Text style={styles.projects__cardTitle}>SP Medical Group</Text>
            <Text style={styles.projects__cardInfo}>Tema: React JS</Text>
            <Text style={styles.projects__cardInfo}>
              Descrição: Criar uma aplicação de gerenciamento para as clínicas
              médicas
            </Text>
            <Text style={styles.projects__cardFooter}>
              Criado por: Vinícius Figueiroa
            </Text>
          </View>
        </View>
      </View>

      <View style={styles.teste}>
        <TouchableOpacity style={styles.button}>
          <Text style={styles.buttonText}>Adicionar projeto</Text>
        </TouchableOpacity>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    backgroundColor: "#F6F7F9",
    flex: 1,
  },

  main: {
    paddingLeft: 20,
    paddingRight: 20,
  },

  title: {
    fontSize: 28,
    color: "#33547D",
    marginTop: 25,
    marginBottom: 25,
  },

  projects__card: {
    backgroundColor: "#fff",
    borderRadius: 6,
    padding: 20,
    minHeight: 159,
    marginBottom: 20,

    shadowColor: "#000",
    shadowOffset: {
      width: 0,
      height: 1,
    },
    shadowOpacity: 0.22,
    shadowRadius: 2.22,

    elevation: 3,
  },

  projects__cardTitle: {
    fontSize: 22,
    color: "#33547D",
  },

  projects__cardInfo: {
    fontSize: 18,
    color: "#7593B6",
    paddingTop: 8,
  },

  projects__cardFooter: {
    fontSize: 18,
    paddingTop: 18,
    color: "#7593B6",
  },

  teste: {
    marginTop: "auto",
    marginRight: "auto",
    marginBottom: 25,
    marginLeft: "auto",
  },

  button: {
    margin: "auto",
    backgroundColor: "#49A2C2",
    width: 167.5,
    height: 60,
    alignItems: "center",
    justifyContent: "center",
    borderRadius: 6,
  },

  buttonText: {
    color: "#fff",
    fontSize: 18,
  },
});
