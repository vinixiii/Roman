//Packages
import React, { useState, useEffect } from "react";
import { StyleSheet, Text, View, FlatList, ScrollView } from "react-native";
import { LinearGradient } from "expo-linear-gradient";

//Services
import api from "../services/api";

//Components
// import { Header } from "../components/Header";
import { Button } from "../components/Button";

export function Projects() {
  const [projectsList, setProjectsList] = useState([]);

  async function getProject() {
    const res = await api.get("/projeto");
    setProjectsList(res.data);
  }

  useEffect(() => {
    getProject();
  }, []);

  const renderItem = ({ item }) => (
    <View style={styles.projects__card}>
      <Text style={styles.projects__cardTitle}>{item.titulo}</Text>
      <Text style={styles.projects__cardInfo}>
        Tema: {item.idTemaNavigation.titulo}
      </Text>
      <Text style={styles.projects__cardInfo}>Descrição: {item.descricao}</Text>
      <Text style={styles.projects__cardFooter}>
        Criado por: {item.idProfessorNavigation.nome}
      </Text>
    </View>
  );

  return (
    <View style={styles.container}>
      {/* <Header /> */}

      <View style={styles.main}>
        <Text style={styles.title}>Projetos</Text>

        <ScrollView style={styles.projectsList}>
          <FlatList
            data={projectsList}
            keyExtractor={(item) => item.title}
            renderItem={renderItem}
          />
        </ScrollView>
      </View>

      <LinearGradient
        colors={["rgba(246, 247, 249, 0.1)", "rgba(255, 255, 255, 1)"]}
        style={styles.footer}
      >
        {/* <View style={styles.footer}> */}
        <Button>Adicionar projeto</Button>
        {/* </View> */}
      </LinearGradient>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    backgroundColor: "#F6F7F9",
    flex: 1,
  },

  main: {
    // flex: 1,
    paddingLeft: 20,
    paddingRight: 20,
  },

  title: {
    // flex: 1,
    // backgroundColor: "blue",

    fontSize: 28,
    color: "#33547D",
    paddingTop: 25,
    paddingBottom: 25,
  },

  projectsList: {
    // flex: 8,
    // backgroundColor: "yellow",
  },

  projects__card: {
    backgroundColor: "#fff",
    borderRadius: 6,
    minHeight: 159,
    padding: 20,
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

  footer: {
    position: "absolute",
    bottom: 0,
    alignSelf: "center",
    width: "100%",
  },
});
